# Workshop de Kubernetes #
El objetivo de este workshop es estudiar y aplicar los conceptos básicos y herramientas para la orquestación de servicios en un clúster de Kubernetes de forma local y en la nube de Azure.

Al completarlo, se espera que manejes:
- Conceptos de Docker y Kubernetes
- Publicación de imágenes en Container Registry
- Configuración de despliegues, servicios y configMaps
- Uso de kubectl
- Creación de pipelines CI/CD en Azure Devops  para construcción, publicación y despliegue de servicios.

## Preparación (4-8 hrs) ##

Primero que todo se debe entender los fundamentos de Docker y Kubernetes. Acá algunos links de documentación:
- https://docs.docker.com/get-started/overview/
- https://kubernetes.io/es/docs/concepts/

Completa el learning path de Microsoft para la creación y manejo de containers usando Docker y Kubernetes:
https://docs.microsoft.com/en-us/learn/paths/az-400-create-manage-containers-using-docker-kubernetes/


## Introducción (1.5 hrs) ##

Generación de un deployment usando kubectl

- Instala Docker for Windows (tardará bastante). Una vez instalado, habilita Kubernetes:

- Luego, verifica que Docker y Kubernetes estén corriendo:


- Sigue las instrucciones para crear un deployment a partir de una imagen de Docker: https://kubernetes.io/es/docs/tutorials/hello-minikube/#crear-un-deployment
- Crea un servicio de tipo LoadBalancer para exponer el deployment: https://kubernetes.io/es/docs/tutorials/hello-minikube/#crear-un-service
- Puedes probar  el funcionamiento en http://localhost:8080/
- Agrega 3 replicas al backend y verifica el estado de los pods.
- No olvides volver todo a la normalidad eliminando el servicio y el deployment usando el comando kubectl delete.


## Despliegue de servicios usando un clúster de  Kubernetes local (6 hrs) ##


Utilizando como base el código de este repositorio, que consiste en una API en .NET 6 y un Frontend en React. Ambos tienen soporte de contenedores.

Realiza lo siguiente:
- Crea archivos YAML de despliegue y servicio para  cada componente
- Configura el frontend para que apunte al servicio de backend
- El deployment del frontend debe usar un configMap con la  URL del backend 
- Publica las imágenes en un Container Registry personal (debes tener una cuenta de DockerHub)
- En un cluster local, provisiona los componentes definidos anteriormente


## Despliegue de servicios usando AKS (10 hrs) ##

Usando la configuración creada anteriormente, ahora harás el despliegue en Azure. Para ello, haz lo siguiente:
- Crea una instancia de Container Registry y un Cluster de AKS (un nodo de dos núcleos es suficiente)
- Publica las imágenes de tus servicios en el Container Registry usando Docker CLI y Azure CLI
- Crea un proyecto de Azure Devops
- Crea los pipelines para: compilación de las imagenes y publicación en el Azure Container Registry, creación de despliegue y servicios en el Cluster de AKS
