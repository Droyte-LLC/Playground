# Make sure Docker Desktop is running
`open -a Docker`

# Pull latest Go Docker image
`docker pull golang`

# To pull a specific version, tag `:version` to the end command
Example: `docker pull golang:1.22`

# Pull the eksctl image
`docker pull public.ecr.aws/eksctl/eksctl`

# Run eksctl image
docker run --rm -it public.ecr.aws/eksctl/eksctl
docker run --rm -it \
  -v ~/.aws:/root/.aws \
  public.ecr.aws/eksctl/eksctl \
  create cluster --name risk-cluster --region us-east-1 --nodes 2



# Mount your local code directory into the container
NOTE: Make sure you're in the correct directory before running this command
`docker run -it --rm -v "$(pwd):/app" -p 8080:8080 golang bash`

Change into your service directory
`cd risk-service`

Create mod file to track dependencies
`go mod init risk-service`

Create you go service, main.go

Build the app
`go build main.go`

Keeps checksums of dependencies to ensure dependency integrity
`go mod tidy`

# Build the image
`docker build -t risk-service .`

# Run the image
docker run --rm -p 8081:8081 risk-service

# Authenticate with AWS
aws configure

# List all EKS Clusters
aws eks list-clusters --region <your-region>

# Push to AWS ECR
  # 1. Authenticate Docker to ECR
  aws ecr get-login-password --region <region> \
  | docker login --username AWS --password-stdin <account_id>.dkr.ecr.<region>.amazonaws.com
  # 2. Create ECR Repository
  aws ecr create-repository --repository-name risk-service --region <region>
  # 3. Tag and push image
  IMAGE=<account_id>.dkr.ecr.<region>.amazonaws.com/risk-service
  docker tag risk-service:latest $IMAGE
  docker push $IMAGE

# Deploy to AWS EKS (Kubernetes)
  # 1. Create deployment.yaml file
  Make sure your container image url is set with the proper ECR url
  # 2. Create service.yaml file
  # 3. Create Cluster
  # 4. Connect kubectl to EKS Cluster
  docker run --rm -it \
  -v ~/.aws:/root/.aws \
  public.ecr.aws/eksctl/eksctl \
  create cluster --name risk-cluster --region us-east-1 --nodes 2
  # 5.Configure kubectl to point to EKS Cluster
  aws eks update-kubeconfig --region us-east-1 --name risk-cluster
  # 5. Deploy to EKS
  kubectl apply -f k8s/deployment.yaml
  kubectl apply -f k8s/service.yaml
  # 6. Test the connection
  kubectl get nodes

  # Get external IP
  kubectl get service risk-service

  # Restart a deployment
  kubectl rollout restart deployment risk-service

  # View logs
  kubectl logs -l app=risk-service

  # Run a test ?
  kubectl run test --rm -it --image=busybox -- /bin/sh

  # Get nodes
  kubectl get nodes

HIGH LEVEL FLOW
----------------
User (Browser, curl)
    |
    v
[ AWS Load Balancer (port 80) ]
    |
    v
[ Kubernetes Service: risk-service ]
    - type: LoadBalancer
    - port: 80
    - targetPort: 8081
    |
    v
[ Pod: risk-service ]
    - containerPort: 8081
    - env: PORT=8081
    |
    v
[ Go App ]
    - http.ListenAndServe(":" + os.Getenv("PORT"))











Run the app
`go run main.go`


------------

This runs a new shell inside an already running container

`docker exec -it <container_name_or_id> bash`

-it: interactive terminal
--rm: removes the container when exiting
-v "$(pwd):/app": mounts your working directory (where your Go project is) to the /app directory inside the container
golang: using the Go image
bash: starts a bash shell inside the container

Dev Environment

Once inside the container, navigate to /app (which is your mounted project directory) and you can use Go commands (e.g., go build, go run, go test) as if Go were installed locally.
This method allows you to isolate your Go development environment within a container, preventing any conflicts with your macOS system and avoiding the need for a local Go installation.





Run commands directly by starting a new container each time
You don't need to use docker exec for this. Instead, you run docker run each time you want to execute an eksctl command. For example:

docker run --rm -it public.ecr.aws/eksctl/eksctl create cluster --name=my-cluster --region=us-west-2

# Pull the eksctl image
docker pull public.ecr.aws/eksctl/eksctl


# Run it
docker run --rm -it \
  -v ~/.aws:/root/.aws \
  public.ecr.aws/eksctl/eksctl sh
--rm: removes the container after you exit.

-it: interactive terminal.

-v ~/.aws:/root/.aws: mounts your local AWS credentials so eksctl inside the container can authenticate with AWS.

sh: starts a shell inside the container.

**TODO
- Create CI/CD, pull secrets from Vault, envsubst