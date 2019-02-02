import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router, ActivatedRoute } from "@angular/router";
import { SlotService } from "../../services/slot.service";

@Component({
  selector: "app-add-slot",
  templateUrl: "./add-slot.component.html",
  styleUrls: ["./add-slot.component.css"]
})
export class AddSlotComponent {
  slotForm: FormGroup;
  title: string = "Create";
  roomId: string;
  startTime: Date;
  staffId: string;
  studentId: string;
  errorMessage: any;

  constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute, private _slotService: SlotService,
    private _router: Router)
  {
    //if(this._avRoute.snapshot.params["id"])
    //{
    //  this.employeeId = this._avRoute.snapshot.params["id"];
    //}
    this.slotForm = this._fb.group({
      roomId: ["", [Validators.required]],
      startTime: ["", [Validators.required]],
      staffId: ["", [Validators.required]],
      studentId: ["", [Validators.required]]
    });
  }

  //ngOnInit()
  //{
  //  this._employeeService.getCityList().subscribe(data => this.cityList = data);
  //  if(this.employeeId > 0)
  //  {
  //    this.title = "Edit";
  //    this._employeeService.getEmployeeById(this.employeeId).subscribe(resp => this.employeeForm.setValue(resp),
  //      error => this.errorMessage = error);
  //  }
  //}

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
    //else if(this.title === "Edit")
    //{
    //  this._employeeService.updateEmployee(this.employeeForm.value).subscribe((data) => {
    //    this._router.navigate(["/fetch-employee"]);
    //  }, error => this.errorMessage = error);
    //}
  }

  cancel()
  {
    this._router.navigate(["/fetch-employee"]);
  }

 
}
