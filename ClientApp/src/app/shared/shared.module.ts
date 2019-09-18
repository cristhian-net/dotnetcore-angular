import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { FilterTextboxComponent } from './filter-textbox.component';

@NgModule({
    imports: [FormsModule],
    exports: [FilterTextboxComponent],
    declarations: [FilterTextboxComponent],
    providers: [],
})
export class SharedModule { }
