'use strict';

function getArrayDirectorios(path) {
    let directorios = path.split('/');
    let directoriosRellenos = [];

    for (let directorio of directorios) {
        if (directorio !== '')
            directoriosRellenos.push(directorio);
    }

    return directoriosRellenos;
}

let directorios = getArrayDirectorios('/etc/apache2/conf/');
for (let directorio of directorios) {
    console.log(directorio);
}