function notify(message) {
  const divMessage = document.querySelector('#notification');
  divMessage.textContent = message;
  divMessage.style.display = 'block';
  divMessage.addEventListener('click' , (e) => {
    e.target.style.display = 'none';
  })

}