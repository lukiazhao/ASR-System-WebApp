import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router, ActivatedRoute } from "@angular/router";
import { SlotService } from "../../services/slot.service";
import { RoomService } from "../../services/room.service";

@Component({
  selector: "app-add-slot",
  templateUrl: "./add-slot.component.html",
  styleUrls: ["./add-slot.component.css"]
})
export class AddSlotComponent implements OnInit {
  slotForm: FormGroup;
  title: string = "Create";
  localRoomId: string;
  localStartTime: Date;
  //staffId: string;
  //studentId: string;
  roomList: Array<any> = [];
  staffList: Array<any> = [];
  errorMessage: any;

  constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute, private _slotService: SlotService,
    private _roomService: RoomService, private _router: Router)
  {
    if(this._avRoute.snapshot.params["id1"] && this._avRoute.snapshot.params["id2"])
    {
      this.localRoomId = this._avRoute.snapshot.params["id1"];
      this.localStartTime = this._avRoute.snapshot.params["id2"];
    }
    this.slotForm = this._fb.group({
      roomId: ["", [Validators.required]],
      startTime: ["", [Validators.required]],
      staffId: ["", [Validators.required]],
      studentId: [""]
    });
  }

  ngOnInit()
  {
    this._roomService.getRoomList().subscribe(data => this.roomList = data);
    this._slotService.getStaffList().subscribe(data => this.staffList = data);
    if (this.localRoomId != null) {
      this.title = "Edit";
      this._slotService.getSlotByRoomTime(this.localRoomId + "_" + this.localStartTime).subscribe(resp => this.slotForm.setValue(resp),
        error => this.errorMessage = error);
    }
  }

  save()
  {
    if(!this.slotForm.valid)
    {
      return;
    }
    if(this.title === "Create")
    {
      this._slotService.saveSlot(this.slotForm.value).subscribe((data) => {
        this._router.navigate(["/fetch-slot"]);
      }, error => this.errorMessage = error);
    }
    else if(this.title === "Edit")
    {
      this._slotService.updateSlot(this.slotForm.value).subscribe((data) => {
        this._router.navigate(["/fetch-slot"]);
      }, error => this.errorMessage = error);
    }
  }

  cancel()
  {
    this._router.navigate(["/fetch-slot"]);
  }

  get roomId() {
    return this.slotForm.get("roomId");
  }

  get startTime() {
    return this.slotForm.get("startTime");
  }

  get staffId() {
    return this.slotForm.get("staffId");
  }

  get studentId() {
    return this.slotForm.get("studentId");
  }

}
