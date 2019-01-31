import { Component } from "@angular/core";
import { Http } from "@angular/http";
import { Router } from "@angular/router";
import { RoomService } from "../../services/room.service";

@Component({
  selector: "app-fetch-room",
  templateUrl: "./fetch-room.component.html",
  styleUrls: ["./fetch-room.component.css"]
})
export class FetchRoomComponent {
  roomList: RoomData[];

  constructor(public http: Http, private _router: Router, private _roomService: RoomService)
  {
    this.getRooms();
  }

  getRooms()
  {
    this._roomService.getRoomList().subscribe(data => {
      return this.roomList = data;
    });
    // dependency injection
    // in startup AddTransient() 


    //for (let x of this.slotList) {
    //  console.log(x.roomID);
    //}
  }

  //delete(employeeID)
  //{
  //  const ans = confirm("Do you want to delete customer with Id: " + employeeID);
  //  if(ans)
  //  {
  //    this._employeeService.deleteEmployee(employeeID).subscribe((data) =>
  //      {
  //        this.getEmployees();
  //      },
  //      error => console.error(error));
  //  }
  //}
}

interface RoomData {
  roomId: string;
}
