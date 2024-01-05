import axios from "axios"
import { useState } from "react"
export default function Datafetch()
{
    let [firstname,setfname]=useState("")
    let[lastname,setlname] = useState("")
    let [avatar,setimg]=useState("")
    let[arr,setarr]=useState([]);

    function handler()
    {
        let promise =axios.get("http://localhost:5114/api/pmp/activities")
        console.log(typeof(promise))
        promise.then((response)=>{
               let arr=(response.data)
               setarr(arr);
               console.log(arr);

        },(reject)=>{
            console.log("something wrong",reject)
        })
    }


    return(
        <>
        <h4>Ajax Get </h4>
        <input type="button" value="GET"
               onClick={handler}
               />
        <div>
       
  {arr.map((item) => {
    return(
        <>
        <span>{item.title}</span>
        
        <span>{item.id}</span>
        <span>{item.balance}</span>
       <br></br>
       <br></br>
        </>
        
    )
    
  }) }

</div>
        </>
    )
}