let names = ['hola', 3, true];
//para arrays
for (const name of names) {
    console.log(name);
}
//moderno
names.forEach(name => {
    console.log(name);
});
//mejor para objetos imprime el índice del array
for (const name in names) {
    console.log(name);
}
