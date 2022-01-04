class Order {
    constructor(item) {
        this.item = item
    }   
    Delivary() {
        console.log(`${this.item} take the order.`)
    }
    
}

class Product extends Order {
    constructor(item) {
        super(item)
    }
    Mobile() {
        console.log(`${this.item} give laptop.`);
    }
}

let p = new Product("sales man");
p.Delivary();
p.Mobile();