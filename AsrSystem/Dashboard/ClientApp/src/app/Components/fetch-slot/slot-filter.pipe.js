"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var SlotFilterPipe = /** @class */ (function () {
    function SlotFilterPipe() {
    }
    SlotFilterPipe.prototype.transform = function (searchString, slots) {
        if (!searchString || !slots)
            return slots;
    };
    return SlotFilterPipe;
}());
exports.SlotFilterPipe = SlotFilterPipe;
//# sourceMappingURL=slot-filter.pipe.js.map