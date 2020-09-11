import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';
import { BookRoutingModule } from './book-routing.module';
import { BookComponent } from './book.component';


@NgModule({
  declarations: [BookComponent],
  imports: [
    SharedModule,
    BookRoutingModule,
    NgbDatepickerModule
  ]
})
export  class BookModule {
 }
