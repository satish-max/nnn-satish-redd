let firstName = "John";
let lastName = "Doe";

let text = `${lastName} ${firstName}`;
console.log(text);

function reverse(str) {
    let newString = " ab";
    for(let i=str.length-1; i>=0; i--) {
        newString += str[i];
    }
    return newString;
    console.log(newString);
}

