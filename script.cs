/* --- Configurações Globais --- */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

html {
    scroll-behavior: smooth;
}

body {
    background-color: #f4f7f6;
    color: #333;
    line-height: 1.6;
}

a {
    text-decoration: none;
    color: inherit;
}

/* --- Menu de Navegação --- */
.navbar {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px 10%;
    background-color: #ffffff;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    position: sticky;
    top: 0;
    z-index: 1000;
}

.navbar .logo {
    font-size: 24px;
    font-weight: bold;
    color: #2c3e50;
}

.navbar .logo span {
    color: #3498db;
}

.navbar ul {
    display: flex;
    list-style: none;
}

.navbar ul li {
    margin-left: 20px;
}

.navbar ul li a {
    font-weight: 500;
    color: #555;
    transition: color 0.3s ease;
}

.navbar ul li a:hover {
    color: #3498db;
}

/* --- Seção Hero (Destaque) --- */
.hero {
    height: 80vh;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
    background: linear-gradient(135deg, #2c3e50, #3498db);
    color: #fff;
    padding: 0 20px;
}

.hero-content h1 {
    font-size: 48px;
    margin-bottom: 20px;
    animation: fadeInDown 1s ease;
}

.hero-content p {
    font-size: 18px;
    max-width: 600px;
    margin: 0 auto 30px auto;
    opacity: 0.9;
}

.btn {
    display: inline-block;
    padding: 12px 30px;
    background-color: #fff;
    color: #3498db;
    font-weight: bold;
    border-radius: 25px;
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
}

/* --- Seção Sobre --- */
.sobre {
    padding: 80px 10%;
    text-align: center;
    background-color: #fff;
}

.sobre h2 {
    font-size: 32px;
    color: #2c3e50;
    margin-bottom: 20px;
    position: relative;
}

.sobre h2::after {
    content: '';
    display: block;
    width: 50px;
    height: 3px;
    background-color: #3498db;
    margin: 10px auto 0 auto;
}

.sobre p {
    max-width: 800px;
    margin: 0 auto;
    font-size: 18px;
    color: #666;
}

/* --- Rodapé --- */
footer {
    background-color: #2c3e50;
    color: #fff;
    text-align: center;
    padding: 20px;
    font-size: 14px;
}

/* --- Animação Simples --- */
@keyframes fadeInDown {
    from {
        opacity: 0;
        transform: translateY(-20px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* --- Responsividade para Celulares --- */
@media (max-width: 768px) {
    .navbar {
        flex-direction: column;
        padding: 15px;
    }

    .navbar ul {
        margin-top: 15px;
    }

    .hero-content h1 {
        font-size: 32px;
    }
    
    .hero-content p {
        font-size: 16px;
    }
}
