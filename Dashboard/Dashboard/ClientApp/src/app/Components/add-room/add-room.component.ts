import { Component, OnInit } from "@angular/core";
import { Http } from "@angular/http";
import { Router, ActivatedRoute } from "@angular/router";
import { RoomService } from "../../services/room.service";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";

@Component({
  selector: "app-add-room",
  templateUrl: "./add-room.component.html",
  //styleUrls: ["./add-room.component.css"]
})
export class AddRoomComponent {
  roomForm: FormGroup;
  title: string = "Create";
  roomId: string;
  errorMessage: any;

  constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute, private _roomService: RoomService,
    private _router: Router) {
    if (this._avRoute.snapshot.params["id"]) {
      this.roomId = this._avRoute.snapshot.params["id"];
    }
    this.roomForm = this._fb.group({
      roomId: 0,
      roomName: ["", [Validators.required]],
    });
  }
  
  save() {
    if (!this.roomForm.valid) {
      return;
    }
    if (this.title === "Create") {
      this._roomService.saveRoom(this.roomForm.value).subscribe((data) => {
        this._router.navigate(["/fetch-room"]);
      }, error => this.errorMessage = error);
    }
    else if (this.title === "Edit") {
      this._roomService.updateRoom(this.roomForm.value).subscribe((data) => {
        this._router.navigate(["/fetch-employee"]);
      }, error => this.errorMessage = error);
    }
  }

  cancel() {
    this._router.navigate(["/fetch-room"]);
  }

  get name() {
    return this.roomForm.get("name");
  }
}

