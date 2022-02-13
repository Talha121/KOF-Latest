import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { StockinService } from './../../../../_service/stockin.service';

@Component({
  selector: 'app-stockin',
  templateUrl: './stockin.component.html',
  styleUrls: ['./stockin.component.scss']
})
export class StockinComponent implements OnInit {
  inventoryList: any[];
  stockinList: any[];
  searchKey: string;
  Searchableproductlist:any[];
  Barcode:any;
  key:string='rowid';
  reverse:boolean=false;
  p:number=1;
  constructor(private stockservice: StockinService, private modalService: NgbModal) { }
 
  ngOnInit(): void {
    this.getstockinItems();
 
  }
  openInventory(content){
    this.modalService.open(content, { centered: true });
  }
  getstockinItems() {
    this.stockservice.GetstockIn().subscribe((next:any) => {
      this.stockinList=[];
      this.inventoryList=[];
      this.stockinList=next.resp; 
      this.Searchableproductlist=next.resp;
      console.log(this.stockinList);
    }, error => {
      console.log(error);
    });
  

  }
  Sort(key){
    this.key=key;
    this.reverse=!this.reverse;
  }
  SearchProduct(){
    if(this.Barcode==""){
     this.stockinList=this.Searchableproductlist
    }
    else{
      if(this.stockinList!=null){
        this.stockinList=this.Searchableproductlist.filter(res=>{
          return res.barcode.match(this.Barcode)
        })
      }
   
    }
  }
}
