var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var AccountModule;
(function (AccountModule) {
    var ViewModels;
    (function (ViewModels) {
        var IAuthorizationVM = /** @class */ (function (_super) {
            __extends(IAuthorizationVM, _super);
            function IAuthorizationVM() {
                return _super !== null && _super.apply(this, arguments) || this;
            }
            return IAuthorizationVM;
        }(Common.ViewModels.IBaseVM));
        ViewModels.IAuthorizationVM = IAuthorizationVM;
    })(ViewModels = AccountModule.ViewModels || (AccountModule.ViewModels = {}));
})(AccountModule || (AccountModule = {}));
//# sourceMappingURL=IAuthorizationVM.js.map