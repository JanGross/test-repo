#! /bin/sh

project_name="ci-test-build"

echo "Building $project_name for Windows"
/Applications/Unity/Unity.app/Contents/MacOS/Unity \
 -batchmode \
 -nographics \
 -silent-crashes \
 -logFile $(pwd)/unity.log \
 -buildWindowsPLayer "$(pwd)/Build/windows/$project.exe" \
 -quit

echo "Build logs"
cat $(pwd)/unity.log