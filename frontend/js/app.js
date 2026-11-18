//-----data-----
const url = "http://localhost:5148/api"

//-----elements-----
const sayHelloBtn = document.getElementById("say-hello-button");
const addingNumbersBtn = document.getElementById("adding-numbers-button");
const comparingNumbersBtn = document.getElementById("comparing-numbers-button");
const magic8BallBtn = document.getElementById("magic-8-ball-button");
const restaurantPickerBtn = document.getElementById("restaurant-picker-button");
const madlibBtn = document.getElementById("madlib-button");

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
const comparingNumbersOutputTwo = document.getElementById("comparing-numbers-output-2");

const magicForm = document.getElementById("magic-form");
const question = document.getElementById("question");
const magicOutput = document.getElementById("magic-output");

const restaurantForm = document.getElementById("restaurant-form");
const restaurantType = document.getElementById("restaurant-type");
const restaurantOutput = document.getElementById("restaurant-output");

const madlibForm = document.getElementById("madlib-form");
const madlib1 = document.getElementById("madlib1");
const madlib2 = document.getElementById("madlib2");
const madlib3 = document.getElementById("madlib3");
const madlib4 = document.getElementById("madlib4");
const madlib5 = document.getElementById("madlib5");
const madlib6 = document.getElementById("madlib6");
const madlib7 = document.getElementById("madlib7");
const madlib8 = document.getElementById("madlib8");
const madlib9 = document.getElementById("madlib9");
const madlib10 = document.getElementById("madlib10");
const madlibOutput = document.getElementById("mad-lib-output");

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

const magicFetch = async () => {
    const response = await fetch(`${url}/magic`);
    const data = await response.json();
    return data;
}

const restaurantFetch = async (restaurantType) => {
    const response = await fetch(`${url}/restaurantpicker/${restaurantType}`);
    const data = await response.json();
    return data;
}

const madlibFetch = async (madlib1, madlib2, madlib3, madlib4, madlib5, madlib6, madlib7, madlib8, madlib9, madlib10) => {
    const response = await fetch(`${url}/madlib/${madlib1}/${madlib2}/${madlib3}/${madlib4}/${madlib5}/${madlib6}/${madlib7}/${madlib8}/${madlib9}/${madlib10}`);
    const data = await response.json();
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

if(magic8BallBtn){
    magic8BallBtn.addEventListener("click", () => {
        window.location.href = "magic8ball.html";
    });
};

if(restaurantPickerBtn){
    restaurantPickerBtn.addEventListener("click", () => {
        window.location.href = "restaurantpicker.html";
    });
};

if(madlibBtn){
    madlibBtn.addEventListener("click", () => {
        window.location.href = "madlib.html";
    });
};


if(helloForm){
    helloForm.addEventListener("submit", async (event) =>{
        event.preventDefault();

        const output = await sayHelloFetch(username.value);

        helloOutput.textContent = output.message;

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

        comparingNumbersOutput.textContent = `${output.messageOne} `;
        comparingNumbersOutputTwo.textContent = `${output.messageTwo} `;

        numThree.value = "";
        numFour.value = "";

    })
}

if(magicForm){
    magicForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await magicFetch(question.value);

        magicOutput.textContent = `${question.value} - ${output.message}`;

        question.value = "";
    })
}

if(restaurantForm){
    restaurantForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await restaurantFetch(restaurantType.value);

        restaurantOutput.textContent = output.message;

        restaurantType.value = "";
    })
}

if(madlibForm){
    madlibForm.addEventListener("submit", async (event) =>{
        event.preventDefault();

        const output = await madlibFetch(madlib1.value, madlib2.value, madlib3.value, madlib4.value, madlib5.value, madlib6.value, madlib7.value, madlib8.value, madlib9.value, madlib10.value);

        madlibOutput.textContent = output.message;

        madlib1.value = ""; 
        madlib2.value = ""; 
        madlib3.value = ""; 
        madlib4.value = ""; 
        madlib5.value = "";
        madlib6.value = ""; 
        madlib7.value = ""; 
        madlib8.value = ""; 
        madlib9.value = ""; 
        madlib10.value = "";

    })
}
