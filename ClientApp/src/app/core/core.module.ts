import { NgModule, Optional, SkipSelf } from '@angular/core';

import { DataService } from './data.service';
import { HttpClientModule } from '@angular/common/http';

import { EnsureModuleLoadedOnceGuard } from '../shared/ensureModuleLoadedOnceGuard';
import { DataFilterService } from './data-filter.service';

@NgModule({
    imports: [
        HttpClientModule
    ],
    providers: [
        DataService,
        DataFilterService
    ],
})
export class CoreModule extends EnsureModuleLoadedOnceGuard {
    //Looks for the module in the parent injector to see if it's already been loaded (only want it loaded once)
    constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
        super(parentModule);
    }
}
