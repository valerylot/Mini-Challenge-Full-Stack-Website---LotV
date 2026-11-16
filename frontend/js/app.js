//-----data-----
const url = "http://localhost:5148/api"

//-----elements-----
const sayHelloBtn = document.getElementById("say-hello-button");
const addingNumbersBtn = document.getElementById("adding-numbers-button");
const comparingNumbersBtn = document.getElementById("comparing-numbers-button");

const helloForm = document.getElementById("hello-form");
const username = document.getElementById("username");
const helloOutput = document.getElementById("hello-output");

const addingNumbersForm = document.getElementById("adding-numbers-form");
const numOne = document.getElementById("num1");
const numTwo = document.getElementById("num2");
const addNumbersOutput = document.getElementById("add-numbers-output");

const comparingNumbersForm = document.getElementById("comparing-numbers-form");
const numThree = document.getElementById("num3");
const numFour = document.getElementById("num4");
const comparingNumbersOutput = document.getElementById("comparing-numbers-output");

//-----functions-----
const comparingFetch = async (numThree, numFour) => {
    const response = await fetch(`${url}/comparison/${numThree}/${numFour}`);
    const data = await response.json();
    // console.log(data);
    return data;
}


const additionFetch = async (numOne, numTwo) => {
    const response = await fetch(`${url}/math/addition/${numOne}/${numTwo}`);
    const data = await response.json();
    // console.log(data);
    return data;
};

const sayHelloFetch = async (username) => {
    const response = await fetch(`${url}/SayHello/${username}`);
    const data = await response.json();
    // console.log(data);
    return data;
}

//-----event listeners-----
if(sayHelloBtn){
sayHelloBtn.addEventListener("click", () => {
    window.location.href = "sayhello.html";
});
};

if(addingNumbersBtn){
addingNumbersBtn.addEventListener("click", () => {
    window.location.href = "adding2numbers.html";
});
};

if(comparingNumbersBtn){
comparingNumbersBtn.addEventListener("click", () => {
    window.location.href = "comparing2numbers.html";
});
};


if(helloForm){
    helloForm.addEventListener("submit", async (event) =>{
        event.preventDefault();

        const output = await sayHelloFetch(username.value);

        helloOutput.textContent = `Hello ${username.value}`;

        username.value = "";
    })
}

if(addingNumbersForm){
addingNumbersForm.addEventListener("submit", async (event) =>{
    event.preventDefault();

    const output = await additionFetch(numOne.value, numTwo.value);

    addNumbersOutput.textContent = `${output.numOne} + ${output.numTwo} = ${output.result}`;

    numOne.value = "";
    numTwo.value = "";
});
};

if(comparingNumbersForm){
    comparingNumbersForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await comparingFetch(numThree.value, numFour.value);

        comparingNumbersOutput.textContent = `${output.message} `;

        numThree.value = "";
        numFour.value = "";

    })
}



