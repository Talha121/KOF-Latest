import { HttpClient, HttpClientModule, HttpEvent, HttpEventType, HttpHeaders, HttpParams } from '@angular/common/http';
import { Component, ElementRef, EventEmitter, Input, OnInit, Output, SimpleChanges, ViewChild } from '@angular/core';

import { FormArray, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
//import { Supplier } from 'src/app/Models/Supplier.model';
 import { Supplier } from './../../../Models/Supplier.model';
import { Product } from './../../../Models/Product.Model';
import { ProductService } from './../../../_service/product.service';
import { FileuploadService } from './../../../_service/fileupload.service';
import { AlertifyService } from '../../../../../src/app/_service/alertify.service';

@Component({
  selector: 'app-Add-Product',
  templateUrl: './Add-Product.component.html',
  styleUrls: ['./Add-Product.component.scss']
})
export class AddProductComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
}