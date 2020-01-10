/*for (var i = 0; i < 5; i++) {
    setTimeout(function() {
        console.log(i);
    }, i * 1000);
}*/

//javascript闭包理解
/* for(let i=0;i<5;i++){
    setTimeout((i)=>{
        console.log(i); 
    },i*1000)
} */

/* for(var i=0;i<5;i++){
    dd(i);
}
function  dd(i){
    setTimeout(function(){
        console.log(i);
    },i*1000)

}
 */
for(var i=0;i<5;i++){
    ~function dd(i){
        setTimeout(function(){
            console.log(i);
        },i*1000)
    }(i)
}
