import { Url } from "url"

export class StockIn{

    productId: number 
    productName: string
    productName_Urdu: string
    category: string
    brand_Name: any
    brand_Name_Urdu: any
    productImage: Url
    barcode: number
    description: string
    description_Urdu: string
    status: boolean
    dateTime: Date
}