# Use existing docker image as a base image
FROM node:20.10.0-alpine3.19


# Download and install a dependency
RUN RUN apk add -U subversion

# Tell the image what to do when it starts
# as a container
CMD ["redis-server"]