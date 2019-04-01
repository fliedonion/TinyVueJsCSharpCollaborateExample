new Vue({
    el: '#app',
    data: {
        message: 'Hello'
    },
    methods: {
        changeMessage: function () {
            if (this.isHello) {
                this.message = 'Good Evening';
            } else {
                this.message = 'Hello';
            }
        },
        callExternal: function() {
            window.external.CsMessageBox(this.message + ' from vue.js');
            // wrapExternal(this.message);
        }
    },
    computed: {
        isHello: function() {
            return this.message === 'Hello'
        }
    }
});

function clickFromOutSide() {
    document.getElementById("mybtn").click();
}

function wrapExternal(message) {
    
}