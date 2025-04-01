import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';

export const routes: Routes = [
    {
        // Configuração da rota padrão para o componente da página principal
        path: '',
        component: HomeComponent
    }
];
