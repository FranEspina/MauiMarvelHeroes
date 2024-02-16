# Maui Marvel Heroes
Aplicación multiplataforma desarrollada con .NET Maui que meustra información sobre personajes, comics y series de comics del universo marvel.

## Funcionalidad
La aplicación muestra una animación como página de inicio, tras la cual, se puede acceder a la página principal, desde donde podremos navegar al resto de páginas.

A cada una de estas páginas se accede con un ``ImageButton`` que previo a una animación, navega a la página destino.

Todas las páginas muestran datos en una colección con scroll infinito. Cada página tiene su propia vista modelo. Pero todas heredan de una misma clase abstracta: con herencia, uso de tipos genéricos y servicios se accede al API de marvel, evitando la duplicidad de código repetitivo.  

### API Marvel developers
Para poder hacer uso del API De marvel debes de registrarte en la página de desarrolladores ([marvel developer portal](https://developer.marvel.com/)) para conseguir tus propias ``API KEY``. Una vez dispongas de la clave pública y privada se la debes proveer al proyecto. 

Por comodidad se incluye la clave privada en la propia aplicación (nunca hagas esto en una aplicación en producción). Se muestra la clase usada a tal efecto:

```
namespace MauiMarvelHeroes.Services.MarvelApi
{
    public static class MarvelApiKeys
    {
        public static string MarvelPublicKey = "your_api_public_key";
        public static string MarvelPrivateKey = "your_api_private_key";
    }
}
```

### Tecnología usada
- Navegación Shell.
- Inyección de dependencias en páginas, vistas modelos y servicios. 
- Consumo de API REST.
- Animaciones.
- Scroll infinito.
- Uso del tema del sistema.

## Capturas de pantalla

### Animaciones página de inicio 
https://github.com/FranEspina/MauiMarvelHeroes/assets/53045314/4f1b5b54-94b8-4d59-9a35-d08b74c141c9

### Página de principal
![Página de principal](https://github.com/FranEspina/MauiMarvelHeroes/assets/53045314/153d9f57-dd81-41a7-8c1f-659676a980ec)

### Vista de una de las colecciones
![Vista de una de las colecciones](https://github.com/FranEspina/MauiMarvelHeroes/assets/53045314/7335a710-a3bf-4f78-8de6-2ea2fbd17c4d)

### Tema claro: Animación inicio - Windows 

![Tema claro: Animación inicio - Windows ](https://github.com/FranEspina/MauiMarvelHeroes/assets/53045314/cbdd3667-0d59-481a-a091-671185b4a11c)

### Tema claro: Lista series comics - Windows

![Tema claro: Lista series comics - Windows](https://github.com/FranEspina/MauiMarvelHeroes/assets/53045314/46229734-1b7c-40dc-b417-4d925c411a94)

## TO DO
- Revisar cada una de las plataformas
- Realizar adaptaciones para Mac y Windows. Actualmente simplemente se cambia el número de elementos en la colección para que muestre más en pantalla.
- Realizar pantallas de detalles de cada elemento que se muestra en las listas.
- Usar marcado de accesibilidad en xaml

## Recursos
Los recursos de contenido e imágenes son facilitados por Marvel a través de su api para desarrolladores. 
- Attribution Text. Data provided by Marvel. © 2024 MARVEL.
- Copyright © 2024 MARVEL

## Tipología 
Las fuentes han sido descargadas de [gcomics](https://gcomics.online/) donde hablan en general de comic y en particular tienen un artículo sobre [tipografía](https://gcomics.online/blog/fuentes-gratis-para-comics/).

En particular se han usado dos fuentes de Nate Piekos que permiten su uso sin fines comerciales. Si quieres usar las fuentes debes tener en cuenta su [fichero de licencia](./MauiMarvelHeroes/Resources/Fonts/fontinfo.txt). 
```
This font is (C) 2015 Nate Piekos.  All Rights Reserved.  
Created for Blambot Fonts
```

 All fonts (C) Nate Piekos. All Rights Reserved. 



