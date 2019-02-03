import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { HomeComponent } from "./home/home.component";

import { SlotService } from "./services/slot.service";
import { FetchSlotComponent } from "./components/fetch-slot/fetch-slot.component";
import { AddSlotComponent } from "./components/add-slot/add-slot.component";

import { RoomService } from "./services/room.service";
import { FetchRoomComponent } from "./components/fetch-room/fetch-room.component";
import { AddRoomComponent } from "./components/add-room/add-room.component";
import { SlotFilterPipe } from "./Components/fetch-slot/slot-filter.pipe";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchSlotComponent,
    AddSlotComponent,
    FetchRoomComponent,
    AddRoomComponent,
    SlotFilterPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    CommonModule,
    HttpClientModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "fetch-slot", component: FetchSlotComponent },
      { path: "add-slot", component: AddSlotComponent },
      { path: "slot/edit/:id1/:id2", component: AddSlotComponent },
      { path: "fetch-room", component: FetchRoomComponent },
      { path: "add-room", component: AddRoomComponent },
      { path: "room/edit/:id", component: AddRoomComponent }
    ])
  ],
  providers: [SlotService, RoomService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
