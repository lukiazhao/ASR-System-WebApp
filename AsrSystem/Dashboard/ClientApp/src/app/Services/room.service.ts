import { Injectable, Inject } from "@angular/core";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import "rxjs/add/operator/map";
import "rxjs/add/operator/catch";
import "rxjs/add/observable/throw";

@Injectable()
export class RoomService {
  myAppUrl: string = "";

  constructor(private _http: Http, @Inject("BASE_URL") baseUrl: string) {
    this.myAppUrl = baseUrl;
  }

  getRoomList() {
    return this._http.get(this.myAppUrl + "api/Admin/GetRooms").map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  saveRoom(room) {
    return this._http.post(this.myAppUrl + "api/Admin/CreateRoom", room).map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  updateRoom(roomId, room) {
    return this._http.put(this.myAppUrl + "api/Admin/EditRoom", { OldRoomId: roomId, NewRoom: room }).map((response: Response) => response.json())
      .catch(this.errorHandler);
  }

  getRoomById(key) {
    return this._http.get(this.myAppUrl + "api/Admin/RoomDetails/" + key).map((response: Response) => response.json())
      .catch(this.errorHandler);
  }


  errorHandler(error: Response) {
    console.log(error);
    return Observable.throw(error);
  }
}
