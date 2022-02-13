import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BannerComponent } from './Banner.component';
import { BannerRoutingModule } from './BannerRouting.routing';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';

@NgModule({
  imports: [
    CommonModule,
    BannerRoutingModule,
    NgxSpinnerModule,
    
  ],
  declarations: [BannerComponent],
  providers: [
    NgxSpinnerService
    ]
})
export class BannerModule { }
