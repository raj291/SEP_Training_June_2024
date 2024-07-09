// Q1.
let salaries = {
    john: 100,
    Ann : 160,
    Pete: 130
}

var sumofSal = salaries.john + salaries.Ann + salaries.Pete;
console.log(sumofSal);
//Q2.
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
    };
function MultiplyNumber(obj){
    for(let key in obj){
        if( typeof obj[key] === 'number'){
            obj[key] *= 2;
        }
    }
}
MultiplyNumber(menu);
console.log(menu);
//Q3.
let email = 'rajzapick.gmail@com';
function checkEmailid(str){
    if(str.includes('@') && str.includes('.') && str.indexOf('@') < str.indexOf('.')){
        return true;
    }
    return false;

}
console.log(checkEmailid(email));

//Q4.
function truncate(str,n){
    if(str.length > n){
        str = str.slice(0 , n) + '...';
        return str;

    }
    return str;
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));
//Q5.
let array = ['James','Brennie'];
array.push('Robert');
console.log(array);
array.splice(array.length/2,1,'Calvin');
console.log(array);
array.shift();
console.log(array);
array.unshift('Rose','Regal');
console.log(array)