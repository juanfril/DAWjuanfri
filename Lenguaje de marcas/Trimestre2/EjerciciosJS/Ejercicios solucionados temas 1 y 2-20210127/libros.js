class Book{
    constructor(title, author, year, gender){
        this.title = title
        this.author = author
        this.year = year
        this.gender = gender
    }

    getAuthor(){
        return this.author;
    }

    getGenero(){
        return this.gender;
    }

    info(){
        return console.log(`Título: ${this.title} \nauthor: ${this.author}\nFecha Salida: ${this.year}\nGénero: ${this.gender}`);
    }
}

let books = [];

while(books.length < 3){
    let title = prompt('Introduce el título del libro')
    let author = prompt('Introduce el autor del libro')
    let year = prompt('Introduce el año del libro')
    let gender = prompt('Introduce el género del libro').toLowerCase()

    if(title != '' &&
        author != '' &&
        !isNaN(year) && year.length == 4 &&
        (gender == 'aventura' || gender == 'terror' || gender == 'fantasia')){
        
        books.push(new Book(title, author, year, gender))
    }
}

const showAllBooks = () => {
    console.log(books);
}
showAllBooks();

const showAuthors = () => {
    for (const book of books) {
        let authors = [];
        authors.push(book.getAuthor());

        console.log(authors.sort());
    }
}
showAuthors();

const showGender = (gender) => {
    for(const book of books) {
        if(book == gender)
            console.log(book.getGenero);
        else
            console.log('No se encuentra en la emeroteca');
    };
}

showGender('Aventura');