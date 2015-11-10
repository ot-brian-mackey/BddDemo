@windir = File.expand_path ENV['WINDIR']

task :default => :start

desc 'show something'
task :start do
  display 'STATUS'
end

def display operation
  puts operation
end

desc 'build with msbuild'
task :build do
  sh "#{@windir}/Microsoft.NET/Framework/v4.0.30319/msbuild.exe /p:Configuration=debug /verbosity:d /p:Platform=\"Any CPU\" /clp:ErrorsOnly /nologo /noautorsp /m"
  display 'finished'
end
