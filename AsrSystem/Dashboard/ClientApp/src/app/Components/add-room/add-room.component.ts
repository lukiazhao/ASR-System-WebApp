import { Component, OnInit } from "@angular/core";
import { Router, ActivatedRoute } from "@angular/router";
import { RoomService } from "../../services/room.service";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";

@Component({
  selector: "app-add-room",
  templateUrl: "./add-room.component.html",
  styleUrls: ["./add-room.component.css"]
})
export class AddRoomComponent implements OnInit {
  roomForm: FormGroup;
  title: string = 'Create';
  localRoomId: string;
  errorMessage: any;

  constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute, private _roomService: RoomService,
    private _router: Router) {
    if (this._avRoute.snapshot.params["id"]) {
      this.localRoomId = this._avRoute.snapshot.params["id"];
    }
    this.roomForm = this._fb.group({
      roomId: ["", [Validators.required]],
    });
  }

  ngOnInit(): void {
    if (this.localRoomId != null) {
      this.title = "Edit";
      this._roomService.getRoomById(this.localRoomId).subscribe(resp => this.roomForm.setValue(resp),
        error => this.errorMessage = error);
    }
  }

  save() {
    console.log("save()");
    if (!this.roomForm.valid) {
      return;
    }
    if (this.title === "Create") {
      this._roomService.saveRoom(this.roomForm.value).subscribe((data) => {
        this._router.navigate(["/fetch-room"]);
      }, error => this.errorMessage = error);
    }
    else if (this.title === "Edit") {
      //const ans = confirm("Warning: Change room may affect corresponding slots");
  

      this._roomService.updateRoom(this.localRoomId, this.roomForm.value).subscribe((data) => {
        if (data == 2) {
          confirm("Error: this room has been booked. You can't edit it :(");
          this._router.navigate(["/fetch-room"]);
        } else if (data == 3) {
          confirm("Internal Error:  Room may exist.");
          this._router.navigate(["/fetch-room"]);
        } else {
          this._router.navigate(["/fetch-room"]);
        }
        }, error => this.errorMessage = error);
      
    }
  }

  cancel() {
    this._router.navigate(["/fetch-room"]);
  }

  get roomId() {
    return this.roomForm.get("roomId");
  }
}

