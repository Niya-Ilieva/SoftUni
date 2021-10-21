function solve([...arr], description) {
    let tickets = [];
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    for (const ticket of arr) {
        let [destination, price, status] = ticket.split('|')
        let currentTicket = new Ticket(destination, Number(price), status);
        tickets.push(currentTicket);
    }
    let sorted;
    if (description == 'destination') {
        sorted= tickets.sort((a, b) => a.destination.localeCompare(b.destination));
    }
    if (description == 'price') {
        sorted= tickets.sort((a, b) => a.price - b.price);
    }
    if (description == 'status') {
        sorted= tickets.sort((a, b) => a.status.localeCompare(b.status));
    }
    return sorted;
}
solve(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'status'
);