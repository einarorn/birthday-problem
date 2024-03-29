build: clean restore lint compile test-unit

clean:
	dotnet clean -v q

restore:
	dotnet restore

lint:
	dotnet format

compile:
	dotnet build

test-unit:
	dotnet test --filter Category=Unit --logger "console;verbosity=normal"