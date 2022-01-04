let fruits = ["banana"]

let arr = fruits;
console.log(arr === fruits);
arr.push("peer");
console.log(fruits);

let arr = ["pine", "banana", "peer"];

for(let i=0; i < arr.length; i++) {
  console.log(arr[i]);
}

let fruits = ["pine", "banana", "cherry"];

for (let fruit of fruits) {
    console.log(fruit);
}