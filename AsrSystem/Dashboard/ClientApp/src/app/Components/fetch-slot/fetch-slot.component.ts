import { Component } from "@angular/core";
import { Http } from "@angular/http";
import { Router } from "@angular/router";
import { SlotService } from "../../services/slot.service";

@Component({
  selector: "app-fetch-slot",
  templateUrl: "./fetch-slot.component.html",
  styleUrls: ["./fetch-slot.component.css"]
})
export class FetchSlotComponent {
  slotList: SlotData[];

  constructor(public http: Http, private _router: Router, private _slotService: SlotService)
  {
    this.getSlots();
  }

  getSlots()
  {
    this._slotService.getSlotList().subscribe(data => this.slotList = data);
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

interface SlotData {
  roomId: string;
  startTime: string;
  staffId: string;
  studentId: string;
}
