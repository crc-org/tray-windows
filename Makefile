CONTAINER_RUNTIME ?= podman

.PHONY: containerized
containerized:
	${CONTAINER_RUNTIME} build -t tray-build -f images/ .
	${CONTAINER_RUNTIME} run --name tray-build tray-build sh -c "nuget restore && xbuild tray-windows.sln"
	${CONTAINER_RUNTIME} cp tray-build:/app/bin ./bin
	${CONTAINER_RUNTIME} rm tray-build
	#${CONTAINER_RUNTIME} rmi tray-build  # this forces a rebuild of the toolchain each time
