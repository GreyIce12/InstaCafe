var app = new Vue({

    el: '#app',

    data: {
        products: [],
        newStock: {
            id: 0,
            description: "Size",
            Quantity:10
        }
    },
    mounted: {

        getStock();
    },
    methods: {

        getStock() {
            this.loading = true;
            axios.get('/Admin/stocks')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        selectProduct(product) {
            this.selectProduct = product;
        },
    },
    computed{

}
})