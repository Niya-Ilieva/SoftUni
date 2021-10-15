function calc() {
    const firstNumber = document.querySelector('#num1').value;
    const secondNumber = document.querySelector('#num2').value;
    const result = Number(firstNumber) + Number(secondNumber);
    
    document.querySelector('#sum').value = result
}
