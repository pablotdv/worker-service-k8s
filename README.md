# k8s probes on .net BackgroundService

fonte: https://dzone.com/articles/monitoring-health-of-aspnet-core-background-servic

### build the image to minikube

```
minikube image build -f Dockerfile . -t worker-service-k8s:latest
```

### apply on k8s

```
kubectl apply -f k8s/deployment.yaml
```

### connect on pod

```
kubectl get pods

kubectl exec --stdin --tty pod/worker-service-k8s-6bbcc4fcc-gf7nx -- bash
```

### to see open connections in the container

```
apt update

apt install net-tools watch

watch -n 1 netstat -ant
```
