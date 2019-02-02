import { Injectable, Inject } from "@angular/core";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import "rxjs/add/operator/map";
import "rxjs/add/operator/catch";
import "rxjs/add/observable/throw";

@Injectable()
export class SlotService {
  myAppUrl: string = "";

  constructor(private _http: Http, @Inject("BASE_URL") baseUrl: string) {
    this.myAppUrl = baseUrl;
  }

  getSlotList() {
    return this._http.get(this.myAppUrl + "api/Admin/Index").map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

   updateSlot(slot) {
    return this._http.put(this.myAppUrl + "api/Admin/EditSlot", slot).map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  saveSlot(slot) {
    
     return this._http.post(this.myAppUrl + "api/Admin/CreateSlot", slot).map((response: Response) => response.json())
        .catch(this.errorHandler);
  }

  deleteSlot(slot) {
    return this._http.delete(this.myAppUrl + "api/Admin/DeleteSlot/", slot).map((response: Response) => response.json())
      .catch(this.errorHandler);
  }


  //getEmployees() {
  //  return this._http.get(this.myAppUrl + "api/Employee/Index").map((response: Response) => response.json())
  //    .catch(this.errorHandler);
  //}

  //getEmployeeById(id: number) {
  //  return this._http.get(this.myAppUrl + "api/Employee/Details/" + id).map((response: Response) => response.json())
  //    .catch(this.errorHandler);
  //}

  //saveEmployee(employee) {
  //  return this._http.post(this.myAppUrl + "api/Employee/Create", employee).map((response: Response) => response.json())
  //    .catch(this.errorHandler);
  //}

  //updateEmployee(employee) {
  //  return this._http.put(this.myAppUrl + "api/Employee/Edit", employee).map((response: Response) => response.json())
  //    .catch(this.errorHandler);
  //}

  //deleteEmployee(id) {
  //  return this._http.delete(this.myAppUrl + "api/Employee/Delete/" + id).map((response: Response) => response.json())
  //    .catch(this.errorHandler);
  //}

  errorHandler(error: Response) {
    console.log(error);
    return Observable.throw(error);
  }
}
