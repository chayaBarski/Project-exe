import axios from "axios";
const  url = "http://localhost:5155/api/Product";
export async function getAllProductsType() {
 try {
    let res = await axios.get(`${url}/ProducsType`)
    console.log(res.data);
    return res.data
  }
  catch (err) {
    return err
  }
       

}

export async function getAllProductsTypeAndSum() {
  try {
     let res = await axios.get(`${url}/ProducsTypeAnsSum`)
     console.log(res.data);
     return res.data
   }
   catch (err) {
     return err
   }
        
 
 }