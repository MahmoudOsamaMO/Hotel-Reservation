# Hotel Reservation 
he Hotel Reservation project is a software application that allows customers to make reservations for hotel rooms. The application follows a clean architecture design to ensure separation of concerns and maintainability.

Presentation Layer (Web Application):
Angular App 

Application Layer:
This layer contains the application-specific business logic and orchestrates the flow of data and operations.
It depends on the domain layer and communicates with it through interfaces.
In the Hotel Reservation project, the application layer will handle user requests, validate input, and coordinate actions such as creating reservations.
Includes interfaces and implementations for services like ReservationService, CustomerService, etc.


Domain Layer:
This layer represents the core business domain of the application and contains the domain models and business rules.
It should be independent of any specific technology or framework.
In the Hotel Reservation project, the domain layer will define the entities like Customer, Room, and Reservation, along with their behaviors and relationships.
Includes entities like Customer, Room, Reservation, and any domain-specific interfaces or enums.


Infrastructure Layer:
This layer provides implementations for external concerns such as data access, external services, and infrastructure-specific code.
It depends on the domain layer but does not have any dependencies on the other layers.
In the Hotel Reservation project, the infrastructure layer will include the data access code using Entity Framework.
Includes the database context, repositories, Unit of Work implementation, and any external service integrations.



