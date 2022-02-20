import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { PosComponent } from './Pos.component';
import { MainPosComponent } from './MainPos/MainPos.component';
import { PosRoutingModule } from './Posrouting.routing';
import { SharedModule } from '../../../../src/app/shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatDialog } from '@angular/material/dialog';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { PosServiceService } from './../../../../src/app/_service/PosService.service';
import { NgxPrintModule } from 'ngx-print';


@NgModule({
  imports: [
    CommonModule,
    PosRoutingModule,
    SharedModule,
    NgxPrintModule,
    ReactiveFormsModule,
    HttpClientModule,
   FormsModule
  ],
  providers: [DatePipe,MatDialog,PosServiceService],
  declarations: [PosComponent],
 
})
export class PosModule { }
