# Festifare

This repository contains an ongoing microservices-based application developed using C#, .NET, PostgreSQL, MongoDB, RabbitMQ, SignalR, NextJS, Docker, and Kubernetes. The project structure and architecture were heavily influenced by Neil Cummings' ([Udemy course](https://www.udemy.com/course/build-a-microservices-app-with-dotnet-and-nextjs-from-scratch/)).

#### Updates

- **October 27, 2023 - AuctionService:** The initial update involved the completion of the AuctionService microservice. It lays the foundation for managing auctions within the application.

- **Current Update November 1, 2023 - SearchService & Synchronous Messaging:** Recently, the SearchService has been completed. Additionally, synchronous HTTP messaging has been established between the AuctionService and SearchService. This integration enhances the interaction and functionality between these two services.

#### Technologies Used

- **C#:** Main programming language for backend services.
- **.NET:** Framework used for building the microservices.
- **PostgreSQL:** Database system utilized for structured data storage.
- **MongoDB:** NoSQL database employed for flexibility in data storage.
- **RabbitMQ:** Message broker enabling asynchronous communication between microservices.
- **SignalR:** Used for real-time communication and updates.
- **NextJS:** Framework utilized for the frontend.
- **Docker:** Containerization tool for packaging services.
- **Kubernetes:** Orchestrates and manages containers to enable scalability and deployment.

#### Roadmap (Upcoming Implementations)

- **User Authentication Service:** Implementing a service responsible for user authentication.
- **Enhanced Frontend Features:** Further development and refinement of frontend elements using NextJS.
- **Integration Testing:** Implementing robust integration tests to ensure seamless communication between services.

### Getting Started

The project uses Docker and Kubernetes for containerization and orchestration. Follow these steps to get the project up and running:

1. Clone the repository.
2. Navigate to individual service directories and refer to their respective `README.md` files for specific setup instructions.
3. Ensure Docker and Kubernetes are installed and running.
4. Use provided scripts or follow instructions to build and deploy services within the Kubernetes cluster.

### Contributors

- [@lunabuilds](https://www.github.com/lunabuilds)

### Support or Contribution

If you find any issues or would like to contribute to this project, please feel free to open an issue or create a pull request. Your assistance is much appreciated!


---
**Note:** Ensure that the `README` is continuously updated as the project progresses and new features are added. Include specific setup instructions, architecture diagrams, and other relevant details for a comprehensive understanding of the project.
