import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NgxSpinnerService } from 'ngx-spinner';
import { VendorService } from '../../../../../src/app/_service/vendors.service';

@Component({
  selector: 'app-AllVendors',
  templateUrl: './AllVendors.component.html',
  styleUrls: ['./AllVendors.component.scss']
})
export class AllVendorsComponent implements OnInit {

 
  VendorsList:any[];
      SearchListOfConsumer:any[];
      searchKey: string;
        key:string='rowid';
      reverse:boolean=false;
      p:number=1;
      @Output() msgToSibling = new EventEmitter<any>();
     
      constructor(private SpinnerService: NgxSpinnerService,private vendorservice:VendorService,private modalService: NgbModal, private router: Router) { }
    
      ngOnInit() {
       this.GetVendors();
      }
      clickFunction(id:number) {
        this.vendorservice.Updatestatus(id).subscribe((next:any)=>{
          this.VendorsList.forEach(x=>{if(x.vender_id==id){x.status=!x.status}});
        }, error => {
          console.log(error);
        });
     
        
      }
   

      openVerticallyCentered(content) {
        this.modalService.open(content, { centered: true });
      }
      GetVendors(){
        this.SpinnerService.show();
        this.vendorservice.Getvendors().subscribe((next:any) => {
          this.VendorsList=[];
      
          this.VendorsList=next.res;
          this.SpinnerService.hide();
         this.SearchListOfConsumer=next.response;
          console.log(this.VendorsList);
          // this.listData = new MatTableDataSource(this.productlist);
          // this.listData.sort=this.sort;
          // this.listData.paginator=this.paginator;
        }, error => {
          console.log(error);
        });
      }
    
      Sort(key){
        this.key=key;
        this.reverse=!this.reverse;
      }

}



