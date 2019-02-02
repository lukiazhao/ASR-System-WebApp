import { Component, OnInit } from "@angular/core";
import { Http } from "@angular/http";
import { Router } from "@angular/router";
import { SlotService } from "../../services/slot.service";
import { SlotData } from "./slotData";

@Component({
  selector: "app-fetch-slot",
  templateUrl: "./fetch-slot.component.html",
  styleUrls: ["./fetch-slot.component.css"]
})
export class FetchSlotComponent implements OnInit {
  slotList: SlotData[];
  //filteredSlots: SlotData[];
  private _searchString: string;

  constructor(public http: Http, private _router: Router, private _slotService: SlotService)
  {}

  ngOnInit(): void {
    this.getSlots();
    //this.filteredSlots = this.slotList;
  }

  getSlots()
  {
    this._slotService.getSlotList().subscribe(data => this.slotList = data);
  }

  delete(roomId, startTime)
  {
    const ans = confirm("Do you want to delete customer with Id: " + roomId + "  " + startTime);
    if(ans)
    {
      this._slotService.deleteSlot(roomId + "_" + startTime).subscribe((data) =>
        {
          this.getSlots();
        },
        error => console.error(error));
    }
  }


  //get searchString(): string {
  //  return this._searchString;
  //}

  //set searchString(value: string) {
  //  this._searchString = value;
  //  this.filteredSlots = this.filterSlots(value);
  //}

  //filterSlots(searchString: string) {
  //  return this.slotList.filter(slot => slot.staffId.indexOf(searchString) !== -1);
  //}
}

//interface SlotData {
//  roomId: string;
//  startTime: string;
//  staffId: string;
//  studentId: string;
//}

