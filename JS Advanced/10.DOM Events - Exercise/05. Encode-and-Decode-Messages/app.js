function encodeAndDecodeMessages() {
    function encodeAndDecodeMessages() {
        //function ascii(c) {return c.charCodeAt(0)};
    
        let messageInput = document.querySelectorAll('textarea')[0];
        let outputMessage = document.querySelectorAll('textarea')[1];
    
        let btns = document.querySelectorAll('button').addEventListener('click', e  =>{
            if (btns[0]) {
                let input = messageInput.value;
                let sendResult = '';
    
                for (let index = 0; index < input.length; index++) {
                    let currentChar = input.charCodeAt(i);
                    sendResult += String.fromCharCode(currentChar + 1)
                }
                messageInput.value = '';
                outputMessage.value = sendResult;
            }
            else if (btn[1]){
                readButton.addEventListener('click', e => {
                let outputResult = '';
    
                for (let index = 0; index < outputMessage.value.length; index++) {
                   let currentChar = input.charCodeAt(i);
                   outputResult += String.fromCharCode(currentChar - 1);
                }
                 outputMessage.value = outputResult;
        })           
    }
 })
}
}