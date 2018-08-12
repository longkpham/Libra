import store from "./store";
import { CHECK_AUTH } from './actions'
//import adminRoutes from "./View/ManageView/adminRoutes";
import { Permission } from "./AppConst";

async function checkPermission(to, from, next) {
    if(!store.getters.isAuthChecked)
        await store.dispatch(CHECK_AUTH);
    next(store.getters.can(to.name));
}

const routes = [
    {
        path: "/",
        redirect: "/CaseView"
    },
    {
        path: "/CaseView",
        name: Permission.CaseListing,
        component: () =>
            import(/* webpackChunkName: "caseview" */ "./View/Home/CaseView.vue"),
        display: "Case",
        navbar: true, //Renders on nav bar if true
        beforeEnter: checkPermission
    }
];
module.exports = routes;
