import { asLiteral } from '@angular/compiler/src/render3/view/util';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Invoice',
  templateUrl: './Invoice.component.html',
  styleUrls: ['./Invoice.component.scss']
})
export class InvoiceComponent implements OnInit {
  printArea:boolean=false;
  constructor() { }

  ngOnInit() {
    
//this.print();
//   window.onafterprint=(this.myFunction);


  }
  print()
  {
    window.print();
  }

  myFunction()
  {
    window.close();
  }
  abc(){
    this.printArea=true
  }



}
