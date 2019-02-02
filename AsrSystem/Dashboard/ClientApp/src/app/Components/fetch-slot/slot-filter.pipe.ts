import { PipeTransform, Pipe } from "@angular/core";
import { SlotData } from "./slotData";

@Pipe({
  name: 'slotFilter',
  pure: false
})
 export class SlotFilterPipe implements PipeTransform {

  transform(slots: SlotData[], searchString: string) {
    console.log("filter pipe executed");
     if (!searchString || !slots)
      return slots;
    if (searchString.toLowerCase().startsWith('s'))
      return slots.filter(slot => slot.studentId && slot.studentId.indexOf(searchString.toLowerCase()) !== -1);
    return slots.filter(slot => slot.staffId.indexOf(searchString.toLowerCase()) !== -1);
   }
   
}
