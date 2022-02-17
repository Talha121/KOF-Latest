import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { OrderDto } from './../../../../../src/app/Models/OrderDto.Model';
import { OrderService } from '../../../../../src/app/_service/order.service';
import { items } from './../../../../../src/app/Models/items.Model';
import { NgxSpinnerService } from 'ngx-spinner';
import html2canvas from 'html2canvas';
@Component({
  selector: 'app-AllOrders',
  templateUrl: './AllOrders.component.html',
  styleUrls: ['./AllOrders.component.scss']
})
export class AllOrdersComponent implements OnInit {
  OrdersList:OrderDto[];
  OrdersList2:any[];
  OrdersListdata:any[];
  orderamount:number=0;
  orderquntity:number=0;
  SearchOrdersList:OrderDto[];
  key:string='rowid';
  reverse:boolean=false;
  p:number=1;
  form: FormGroup;
  orderid:number;
  orderNo:string="";
  orderitemns:items[];
  neworderdata:any;
  vendorname:string;
  statusorderid:number;
  status:string;
  ordercurrentstatus:string;
  ss:boolean=false;
  orderstatus:FormGroup=new FormGroup({
    orderId:new FormControl(''),
    status: new FormControl('')
  
   });
   FromDate:Date=new Date();
   toDate:Date=new Date();
  constructor(private SpinnerService: NgxSpinnerService,private orderservice:OrderService,private modalService: NgbModal,) { 

  }

  ngOnInit() {
   
    this.GetOrders();
 
  
  }
     filterdate(){
     debugger;
     console.log(this.FromDate)
     console.log(this.toDate)
      this.OrdersList2=this.OrdersListdata.filter(x=>new Date(x.order.createdOn)>= new Date(this.FromDate)&&new Date(x.order.createdOn)<=new Date(this.FromDate) );
  }
  public toCanvas() {
        let elem = document.getElementById("invoice-POS");
        html2canvas(elem).then(function (canvas) {
          let generatedImage = canvas.toDataURL("image/png").replace("image/png", "image/octet-stream");
          let a = document.createElement('a');
          a.href = generatedImage;
          a.download = `${"invoice-POS"}.png`;
          a.click();
        });
    
  }
  openOrderDetailLg(content,data:any) {
    debugger

    this.orderitemns=data;
    this.orderamount=data.total;
    this.orderquntity=data.qty;
    this.orderNo=data.order.orderNumber;
    console.log(data)
    this.modalService.open(content, { size: 'lg' });
  }
  openOrderUpdateLg(content,data:any) {
   this.statusorderid=data.id;
 
    this.ordercurrentstatus=data.orderStatus;
    this.modalService.open(content, { size: 'lg' });
  }
  onOptionsOrderStatusSelected(){
((this.orderstatus.get('orderId').patchValue(this.statusorderid)));
let orderinfo=this.OrdersList2.find(x=>x.order.id==this.statusorderid);
orderinfo.order.orderStatus =this.orderstatus.value.status;
this.orderservice.UpdateOrderStatus(orderinfo.order).subscribe(next => {
  this.GetOrders();
 }, error => {
   console.log(error);
 });


    
  }
  changeorderstatus(data:any,status:string){
debugger;
data.orderStatus=status;
    this.orderservice.UpdateOrderStatus(data).subscribe(next => {
      this.GetOrders();
     }, error => {
       console.log(error);
     });
    
    
        
      }
  onOptionsSelected(num){
    debugger
    if(num=="0"){
      this.OrdersList2=this.OrdersListdata;
    }
    if(num=="1"){
      this.status="Pending";
      this.OrdersList2=this.OrdersListdata.filter(x=>x.order.orderStatus ==this.status);
    }
    if(num=="2"){
      this.status="Active";
      this.OrdersList2=this.OrdersListdata.filter(x=>x.order.orderStatus ==this.status);
    }
    if(num=="3"){
      this.status="Completed";
      this.OrdersList2=this.OrdersListdata.filter(x=>x.order.orderStatus ==this.status);
    }
    if(num=="4"){
      this.status="Cancelled";
      this.OrdersList2=this.OrdersListdata.filter(x=>x.order.orderStatus ==this.status);
    }

  }
  SearchRider(){
    if(this.vendorname==""){
      this.SearchOrdersList=this.OrdersList
     }
     else{
       if(this.OrdersList!=null){
         this.SearchOrdersList=this.OrdersList.filter(res=>{
           return res.vendorname.match(this.vendorname)
         })
       }
    
     }
  }
 
  changestatus(data:any){
    this.orderservice.UpdateOrderStatus(data).subscribe(next => {
      this.GetOrders();
     }, error => {
       console.log(error);
     });
}
  GetOrders(){
    
    this.orderservice.GetOrders().subscribe((next:any) => {
      
      this.OrdersList2=[];
      this.OrdersList2=next;
    
      this.OrdersListdata=next;
   
     
    }, error => {
      console.log(error);
    });
 
  }

  Sort(key){
    this.key=key;
    this.reverse=!this.reverse;
  }

}
