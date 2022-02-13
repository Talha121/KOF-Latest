import { billinginfo } from "./billinginfo.Models";
import { items } from "./items.Model";

export class OrderDto {
    items:items[]
    billinginfo:billinginfo;
    date:string;
    orderId:number;
    status:string;
    vendorname:string;
    deliveringdate:string;
    ordercode:string;
    code:string;
    storename:string
}
