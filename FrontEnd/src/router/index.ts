import { createRouter, createWebHistory } from "vue-router"
//import CarteleraView from "../views/CarteleraView.vue"
import AboutUsView from "../views/AboutUsView.vue"
import CarteleraView from "../views/CarteleraView.vue"
import HomeView from "../views/HomeView.vue"

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: '/',
            name:'home',
            component: HomeView
        },
        {
            path: '/cartelera',
            name: 'cartelera',
            component: CarteleraView
        },
        {
            path: '/about',
            name: 'about',
            component: AboutUsView
        }
    ]
})

export default router