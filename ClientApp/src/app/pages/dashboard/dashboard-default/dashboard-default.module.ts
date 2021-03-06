import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardDefaultRoutingModule } from './dashboard-default-routing.module';
import { DashboardDefaultComponent } from './dashboard-default.component';
import {SharedModule} from '../../../shared/shared.module';
import {ChartModule} from 'angular2-chartjs';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { StockinComponent } from './stockin/stockin.component';
import { Ng2OrderModule, Ng2OrderPipe } from 'ng2-order-pipe';
import { NgxPaginationModule } from 'ngx-pagination';
import { StockinService } from './../../../_service/stockin.service';
import { StockIn } from './../../../Models/stockin';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { DatefilterDto } from '../../../../../src/app/Models/DatefilterDto';
@NgModule({
  imports: [
    CommonModule,
    DashboardDefaultRoutingModule,
    SharedModule,
    ChartModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule, 
    Ng2OrderModule,
    NgxPaginationModule,
    NgxSpinnerModule
  ],
  declarations: [DashboardDefaultComponent,StockinComponent],
  providers: [DatefilterDto,
    StockinService,
    StockIn,NgxSpinnerService 
  ]

})
export class DashboardDefaultModule { }
