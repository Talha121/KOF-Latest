import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SalesmanComponent } from './Salesman.component';
import { SalesmanRoutingModule } from './Salesmanrouting.routing';
import { AddSalesmanComponent } from './AddSalesman/AddSalesman.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { Ng2OrderModule } from 'ng2-order-pipe';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';
import { SharedModule } from '../../../../src/app/shared/shared.module';
import { Salesman } from '../../../../src/app/Models/Salesman';
import { MatInputModule, MatStepperModule } from '@angular/material';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { AllSalesmansComponent } from './AllSalesmans/AllSalesmans.component';

@NgModule({
  imports: [
    CommonModule,
    SalesmanRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxDropzoneModule,
    Ng2OrderModule,
    Ng2SearchPipeModule,
    NgxPaginationModule,
    NgxSpinnerModule,  
    SharedModule,
    FormsModule,
    MatStepperModule,
    MatInputModule
  ],
  declarations: [SalesmanComponent,AddSalesmanComponent,AllSalesmansComponent],
  providers:[Salesman,NgxSpinnerService]
})
export class SalesmanModule { }
