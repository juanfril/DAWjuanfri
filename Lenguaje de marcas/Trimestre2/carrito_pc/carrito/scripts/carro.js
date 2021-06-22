'use strict';

((d) => {
    const $articles = d.querySelectorAll('.item'),
        $shoppingCart = d.getElementById('cart_items');

        const getArticle = article => {
            const newArticle = article.cloneNode(true);
            newArticle.id = 'c' + newArticle.id;
            newArticle.lastElementChild.style.display = 'none';
            newArticle.style.cursor = 'default';
            linkDelete(newArticle);
            return newArticle;
        };
        const linkDelete = article => {
            let link = d.createElement('a');
            link.href = '#';
            link.setAttribute('class', 'delete');
            article.insertBefore(link, article.children[0]);
        };
        const insertArticle = article => {
            const articleInsert = getArticle(article);
            $shoppingCart.insertBefore(articleInsert, $shoppingCart.children[0]);
            setStock(article, -1);
            addShoppingPrice(article);
            setCantidad();
        };
        const getStock = article => {
            return article.lastElementChild.textContent.split(' ');
        };
        const setStock = (article, value) => {
            const articleStock = article.lastElementChild;
            const valueStock = getStock(article);
            valueStock[1] = parseInt(valueStock[1]) + value;
            articleStock.textContent = valueStock[0] + ' ' + valueStock[1];
            if(parseInt(valueStock[1]) === 0) {
                articleStock.classList.add('agotado');
                alert('No queda stock');
            } else {
                articleStock.classList.remove('agotado');
            }
        };
        const deleteArticle = article => {
            $shoppingCart.removeChild(article);
            const splitId = article.id.substring(1,3);
            const $originArticle = d.getElementById(splitId);
            setStock($originArticle, 1);
            removeShoppingPrice(article);
            setCantidad();
        };
        const getPrice = article => {
            return article.querySelector('.price').textContent.split(' ');
        };
        const addShoppingPrice = article => {
            const price = getPrice(article);
            const $total = d.querySelector('#cprice');
            $total.value = (parseInt($total.value) + parseInt(price[0])) + ` ${price[1]}`;
        };
        const removeShoppingPrice = article => {
            const price = getPrice(article);
            const $total = d.querySelector('#cprice');
            $total.value = (parseInt($total.value) - parseInt(price[0])) + ` ${price[1]}`;
        };
        const setCantidad = () => {
            const count = d.getElementById('citem');
            count.value = $shoppingCart.childNodes.length;
        };
        const clearShoppingCart = () => {
            const $links = d.querySelectorAll('.delete');
            $links.forEach(link => link.click());
        }

        d.addEventListener('dblclick', e => {
            if(e.target.parentNode.matches('.item')){
                if(e.target.parentNode.id[0] !== 'c')
                    insertArticle(e.target.parentNode);
            }
        });
        d.addEventListener('click', e => {
            if(e.target.matches('.delete')){
                deleteArticle(e.target.parentNode);
            }
            if(e.target.matches('#btn_clear')){
                clearShoppingCart();
            }
        });
    
})(document);