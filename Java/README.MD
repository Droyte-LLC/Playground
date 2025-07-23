## Environment Setup Tips for Java

// check installed java versions
/usr/libexec/java_home -V

// install java 17
brew install openjdk@17


// verify Java 17 Installed via Homebrew
brew list --versions openjdk@17

// manually register Java 17 with MacOS
sudo ln -sfn /usr/local/opt/openjdk@17/libexec/openjdk.jdk \
  /Library/Java/JavaVirtualMachines/openjdk-17.jdk

nano ~/.bash_profile  # if you use bash

export JAVA_HOME=$(/usr/libexec/java_home -v 17)
export PATH=$JAVA_HOME/bin:$PATH



