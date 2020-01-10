 function Test(data){
    return new Promise(function(res,rej){
        let data1=data  || {name:"Jtian",age:30};
        let json =JSON.stringify(data1)
        if(json){
            res(json)
        }else{
            rej(json)
        }
    })
}
async function ss(){
    let data
    let m = await Test(data);
    
    console.log("开始");
    console.log(m);
    console.log("end")
}


ss()
